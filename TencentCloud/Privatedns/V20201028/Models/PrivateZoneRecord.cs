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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrivateZoneRecord : AbstractModel
    {
        
        /// <summary>
        /// 记录id
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 私有域id: zone-xxxxxxxx
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 子域名
        /// </summary>
        [JsonProperty("SubDomain")]
        public string SubDomain{ get; set; }

        /// <summary>
        /// 记录类型，可选的记录类型为："A", "AAAA", "CNAME", "MX", "TXT", "PTR"
        /// </summary>
        [JsonProperty("RecordType")]
        public string RecordType{ get; set; }

        /// <summary>
        /// 记录值
        /// </summary>
        [JsonProperty("RecordValue")]
        public string RecordValue{ get; set; }

        /// <summary>
        /// 记录缓存时间，数值越小生效越快，取值1-86400s, 默认 600
        /// </summary>
        [JsonProperty("TTL")]
        public long? TTL{ get; set; }

        /// <summary>
        /// MX优先级：记录类型为MX时必填。取值范围：5,10,15,20,30,40,50
        /// </summary>
        [JsonProperty("MX")]
        public long? MX{ get; set; }

        /// <summary>
        /// 记录状态：ENABLED
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 记录权重，值为1-100
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// 记录创建时间
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 记录更新时间
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public string UpdatedOn{ get; set; }

        /// <summary>
        /// 附加信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 0暂停，1启用
        /// </summary>
        [JsonProperty("Enabled")]
        public ulong? Enabled{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "SubDomain", this.SubDomain);
            this.SetParamSimple(map, prefix + "RecordType", this.RecordType);
            this.SetParamSimple(map, prefix + "RecordValue", this.RecordValue);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "MX", this.MX);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

