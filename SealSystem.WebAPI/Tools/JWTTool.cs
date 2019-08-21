using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SealSystem.WebAPI.Tools
{
    /// <summary>
    /// jwt加解密类
    /// </summary>
    public class JWTTool
    {
        private static string Key = "www.xxk.com";
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="key">秘钥(不要告诉别人),如果不传，默认调用已定义的key</param>
        /// <returns></returns>
        public static string Encode(Dictionary<string, object> payload, string key = null)
        {
            if (string.IsNullOrEmpty(key))
            {
                key = Key;
            }
            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            IJsonSerializer serializer = new JsonNetSerializer();
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
            payload.Add("timeout", DateTime.Now.AddDays(1));//1天过期
            return encoder.Encode(payload, key);
        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="toKen"></param>
        /// <param name="key">秘钥(不要告诉别人)如果不传，默认调用已定义的key</param>
        /// <returns></returns>
        public static Dictionary<string, object> Decode(string toKen, string key = null)
        {
            if (string.IsNullOrEmpty(key))
            {
                key = Key;
            }
            try
            {
                IJsonSerializer serializer = new JsonNetSerializer();
                IDateTimeProvider provider = new UtcDateTimeProvider();
                IJwtValidator validator = new JwtValidator(serializer, provider);
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder);
                Dictionary<string, object> dictJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(decoder.Decode(toKen, key, true));
                //判断是否过期,是否小于当前时间
                if ((DateTime)dictJson["timeout"] < DateTime.Now) throw new Exception("jwt 已经过期，请重新登录");
                dictJson.Remove("timeout");
                return dictJson;
            }
            catch (TokenExpiredException ex)
            {
                Console.WriteLine("令牌过期了");
                throw ex;
            }
            catch (SignatureVerificationException ex)
            {
                Console.WriteLine("令牌的签名无效");
                throw ex;
            }
        }
    }
}