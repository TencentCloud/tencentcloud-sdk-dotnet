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

    public class IntegrationDepartment : AbstractModel
    {
        
        /// <summary>
        /// 部门ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeptId")]
        public string DeptId{ get; set; }

        /// <summary>
        /// 部门名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeptName")]
        public string DeptName{ get; set; }

        /// <summary>
        /// 父部门ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentDeptId")]
        public string ParentDeptId{ get; set; }

        /// <summary>
        /// 客户系统部门ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeptOpenId")]
        public string DeptOpenId{ get; set; }

        /// <summary>
        /// 序列号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderNo")]
        public ulong? OrderNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeptId", this.DeptId);
            this.SetParamSimple(map, prefix + "DeptName", this.DeptName);
            this.SetParamSimple(map, prefix + "ParentDeptId", this.ParentDeptId);
            this.SetParamSimple(map, prefix + "DeptOpenId", this.DeptOpenId);
            this.SetParamSimple(map, prefix + "OrderNo", this.OrderNo);
        }
    }
}

