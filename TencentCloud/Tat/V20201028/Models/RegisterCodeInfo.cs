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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegisterCodeInfo : AbstractModel
    {
        
        /// <summary>
        /// 注册码ID。
        /// </summary>
        [JsonProperty("RegisterCodeId")]
        public string RegisterCodeId{ get; set; }

        /// <summary>
        /// 注册码描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 注册实例名称前缀。
        /// </summary>
        [JsonProperty("InstanceNamePrefix")]
        public string InstanceNamePrefix{ get; set; }

        /// <summary>
        /// 该注册码允许注册的实例数目。
        /// </summary>
        [JsonProperty("RegisterLimit")]
        public long? RegisterLimit{ get; set; }

        /// <summary>
        /// 该注册码的过期时间，按照 ISO8601 标准表示，并且使用 UTC 时间。 
        /// 格式为： YYYY-MM-DDThh:mm:ssZ。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// 该注册码限制tat_agent只能从IpAddressRange所描述公网出口进行注册。
        /// </summary>
        [JsonProperty("IpAddressRange")]
        public string IpAddressRange{ get; set; }

        /// <summary>
        /// 该注册码是否可用。
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 该注册码已注册数目。
        /// </summary>
        [JsonProperty("RegisteredCount")]
        public long? RegisteredCount{ get; set; }

        /// <summary>
        /// 注册码创建时间，按照 ISO8601 标准表示，并且使用 UTC 时间。 
        /// 格式为： YYYY-MM-DDThh:mm:ssZ。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 注册码最近一次更新时间，按照 ISO8601 标准表示，并且使用 UTC 时间。 
        /// 格式为： YYYY-MM-DDThh:mm:ssZ。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegisterCodeId", this.RegisterCodeId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "InstanceNamePrefix", this.InstanceNamePrefix);
            this.SetParamSimple(map, prefix + "RegisterLimit", this.RegisterLimit);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "IpAddressRange", this.IpAddressRange);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "RegisteredCount", this.RegisteredCount);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
        }
    }
}

