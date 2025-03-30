/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MQTTAuthenticatorItem : AbstractModel
    {
        
        /// <summary>
        /// 认证器类型
        /// JWT：JWT认证器
        /// JWKS：JWKS认证器
        /// HTTP：HTTP认证器
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// JWT认证器字段说明
        /// from（认证字段）
        ///     password：从password字段获取认证字段
        ///     username：从username字段获取认证字段
        /// secret（签名方式）
        ///     hmac-based：hmac-based签名方式
        ///     public-key：public-key签名方式
        /// secret（密钥），hmac-based需要配置密钥
        /// public-key（公钥），public-key签名方式需要配置
        /// 样例：{"from":"password","secret":"secret282698","algorithm":"hmac-based"}
        /// 
        /// JWKS认证器字段说明
        /// endpoint（接入点）：公钥获取服务器接入地址
        /// refreshInterval（认证内容）：公钥集合刷新周期
        /// from（认证字段）
        ///     password：从password字段获取认证字段
        ///     username：从username字段获取认证字段
        /// text：公钥集合
        /// 样例：{"endpoint":"127.0.0.1","refreshInterval":60,"from":"password"}
        /// 
        /// HTTP认证器
        /// headers（请求头）：标准请求头和自定义请求头
        /// endpoint（接入点）：认证服务器接入点
        /// method（http请求方法）：POST/GET
        /// readTimeout（读超时时间）：读取认证服务器数据超时时间，单位秒
        /// connectTimeout（连接超时时间）：连接认证服务器超时时间，单位秒
        /// body（请求体）：http请求体
        /// concurrency（并发数）：最大并发请求数量
        /// 样例：{"headers":[{"key":"Content-type","value":"application/json"},{"key":"username","value":"${Username}"}],"endpoint":"https://127.0.0.1:443","method":"POST","readTimeout":10,"connectTimeout":10,"body":[{"key":"client-id","value":"${ClientId}"}],"concurrency":8}
        /// 参考 [认证管理概述](https://cloud.tencent.com/document/product/1778/114813)
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// 认证器状态
        /// open：认证器打开
        /// close：认证器关闭
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 创建时间，毫秒级时间戳 。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 说明，最长 128 字符。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

