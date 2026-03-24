/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Aggregator : AbstractModel
    {
        
        /// <summary>
        /// 账号组名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 账号组描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 创建者用户ID
        /// </summary>
        [JsonProperty("OwnerUin")]
        public ulong? OwnerUin{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 账号组成员数量
        /// </summary>
        [JsonProperty("AccountCount")]
        public ulong? AccountCount{ get; set; }

        /// <summary>
        /// RD:全局账号组
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 账号组ID
        /// </summary>
        [JsonProperty("AccountGroupId")]
        public string AccountGroupId{ get; set; }

        /// <summary>
        /// 账号组状态
        /// </summary>
        [JsonProperty("AggregatorStatus")]
        public ulong? AggregatorStatus{ get; set; }

        /// <summary>
        /// 账号组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemberName")]
        public string MemberName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "AccountCount", this.AccountCount);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AccountGroupId", this.AccountGroupId);
            this.SetParamSimple(map, prefix + "AggregatorStatus", this.AggregatorStatus);
            this.SetParamSimple(map, prefix + "MemberName", this.MemberName);
        }
    }
}

