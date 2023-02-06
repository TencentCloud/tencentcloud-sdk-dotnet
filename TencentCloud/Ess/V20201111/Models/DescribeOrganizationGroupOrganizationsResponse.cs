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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOrganizationGroupOrganizationsResponse : AbstractModel
    {
        
        /// <summary>
        /// 查询到的符合条件的成员企业总数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// 已授权待激活的企业数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JoinedTotal")]
        public ulong? JoinedTotal{ get; set; }

        /// <summary>
        /// 已加入的企业数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivedTotal")]
        public ulong? ActivedTotal{ get; set; }

        /// <summary>
        /// 导出文件的url
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExportUrl")]
        public string ExportUrl{ get; set; }

        /// <summary>
        /// 成员企业信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("List")]
        public GroupOrganization[] List{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "JoinedTotal", this.JoinedTotal);
            this.SetParamSimple(map, prefix + "ActivedTotal", this.ActivedTotal);
            this.SetParamSimple(map, prefix + "ExportUrl", this.ExportUrl);
            this.SetParamArrayObj(map, prefix + "List.", this.List);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

