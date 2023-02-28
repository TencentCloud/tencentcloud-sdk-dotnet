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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HttpsPackage : AbstractModel
    {
        
        /// <summary>
        /// HTTPS请求包 Id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// HTTPS请求包类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// HTTPS请求包大小（单位为：次）
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 已消耗HTTPS请求包（单位为：次）
        /// </summary>
        [JsonProperty("SizeUsed")]
        public long? SizeUsed{ get; set; }

        /// <summary>
        /// HTTPS请求包状态
        /// enabled：已启用
        /// expired：已过期
        /// disabled：未启用
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// HTTPS请求包发放时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// HTTPS请求包生效时间
        /// </summary>
        [JsonProperty("EnableTime")]
        public string EnableTime{ get; set; }

        /// <summary>
        /// HTTPS请求包过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// HTTPS请求包来源
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// HTTPS请求包生命周期月数
        /// </summary>
        [JsonProperty("LifeTimeMonth")]
        public long? LifeTimeMonth{ get; set; }

        /// <summary>
        /// HTTPS请求包是否支持退费
        /// </summary>
        [JsonProperty("RefundAvailable")]
        public bool? RefundAvailable{ get; set; }

        /// <summary>
        /// HTTPS请求包类型id
        /// </summary>
        [JsonProperty("ConfigId")]
        public long? ConfigId{ get; set; }

        /// <summary>
        /// HTTPS请求包实际生效时间
        /// </summary>
        [JsonProperty("TrueEnableTime")]
        public string TrueEnableTime{ get; set; }

        /// <summary>
        /// HTTPS请求包实际过期时间
        /// </summary>
        [JsonProperty("TrueExpireTime")]
        public string TrueExpireTime{ get; set; }

        /// <summary>
        /// HTTPS请求包生效区域 
        /// global：全球
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// HTTPS请求包是否续订
        /// </summary>
        [JsonProperty("ContractExtension")]
        public bool? ContractExtension{ get; set; }

        /// <summary>
        /// HTTPS请求包是否支持续订
        /// </summary>
        [JsonProperty("ExtensionAvailable")]
        public bool? ExtensionAvailable{ get; set; }

        /// <summary>
        /// HTTPS请求包当前续订模式
        /// 0：未续订
        /// 1：到期续订
        /// 2：用完续订
        /// 3：到期或用完续订
        /// </summary>
        [JsonProperty("ExtensionMode")]
        public ulong? ExtensionMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "SizeUsed", this.SizeUsed);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EnableTime", this.EnableTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "LifeTimeMonth", this.LifeTimeMonth);
            this.SetParamSimple(map, prefix + "RefundAvailable", this.RefundAvailable);
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "TrueEnableTime", this.TrueEnableTime);
            this.SetParamSimple(map, prefix + "TrueExpireTime", this.TrueExpireTime);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "ContractExtension", this.ContractExtension);
            this.SetParamSimple(map, prefix + "ExtensionAvailable", this.ExtensionAvailable);
            this.SetParamSimple(map, prefix + "ExtensionMode", this.ExtensionMode);
        }
    }
}

