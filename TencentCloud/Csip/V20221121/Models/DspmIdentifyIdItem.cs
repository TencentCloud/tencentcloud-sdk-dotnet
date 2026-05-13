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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmIdentifyIdItem : AbstractModel
    {
        
        /// <summary>
        /// 身份id。
        /// </summary>
        [JsonProperty("IdentifyId")]
        public string IdentifyId{ get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 身份类型。0-未定义 2-长期身份 3-临时身份
        /// </summary>
        [JsonProperty("IdentifyType")]
        public long? IdentifyType{ get; set; }

        /// <summary>
        /// 所属云账号uin用户。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUin")]
        public DspmUinUser OwnerUin{ get; set; }

        /// <summary>
        /// 创建者账号uin用户。
        /// </summary>
        [JsonProperty("CreatorUin")]
        public DspmUinUser CreatorUin{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 状态。0-不活跃 1-活跃
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 所属个人用户信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Person")]
        public DspmPersonUser Person{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdentifyId", this.IdentifyId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "IdentifyType", this.IdentifyType);
            this.SetParamObj(map, prefix + "OwnerUin.", this.OwnerUin);
            this.SetParamObj(map, prefix + "CreatorUin.", this.CreatorUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Person.", this.Person);
        }
    }
}

