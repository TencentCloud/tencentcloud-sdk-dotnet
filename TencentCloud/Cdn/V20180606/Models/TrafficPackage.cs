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

    public class TrafficPackage : AbstractModel
    {
        
        /// <summary>
        /// 流量包 Id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 流量包类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 流量包大小（单位为 Byte）
        /// </summary>
        [JsonProperty("Bytes")]
        public long? Bytes{ get; set; }

        /// <summary>
        /// 已消耗流量（单位为 Byte）
        /// </summary>
        [JsonProperty("BytesUsed")]
        public long? BytesUsed{ get; set; }

        /// <summary>
        /// 流量包状态
        /// enabled：已启用
        /// expired：已过期
        /// disabled：未启用
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 流量包发放时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 流量包生效时间
        /// </summary>
        [JsonProperty("EnableTime")]
        public string EnableTime{ get; set; }

        /// <summary>
        /// 流量包过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 流量包是否续订
        /// </summary>
        [JsonProperty("ContractExtension")]
        public bool? ContractExtension{ get; set; }

        /// <summary>
        /// 流量包是否自动续订
        /// </summary>
        [JsonProperty("AutoExtension")]
        public bool? AutoExtension{ get; set; }

        /// <summary>
        /// 流量包来源
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Bytes", this.Bytes);
            this.SetParamSimple(map, prefix + "BytesUsed", this.BytesUsed);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EnableTime", this.EnableTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ContractExtension", this.ContractExtension);
            this.SetParamSimple(map, prefix + "AutoExtension", this.AutoExtension);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
        }
    }
}

