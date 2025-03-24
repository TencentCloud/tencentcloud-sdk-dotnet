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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SelfOperation : AbstractModel
    {
        
        /// <summary>
        /// 联系人员电话
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StuffContact")]
        public string StuffContact{ get; set; }

        /// <summary>
        /// 身份证号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StuffIDCard")]
        public string StuffIDCard{ get; set; }

        /// <summary>
        /// 人员姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StuffName")]
        public string StuffName{ get; set; }

        /// <summary>
        /// 上门时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperationTime")]
        public string OperationTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StuffContact", this.StuffContact);
            this.SetParamSimple(map, prefix + "StuffIDCard", this.StuffIDCard);
            this.SetParamSimple(map, prefix + "StuffName", this.StuffName);
            this.SetParamSimple(map, prefix + "OperationTime", this.OperationTime);
        }
    }
}

