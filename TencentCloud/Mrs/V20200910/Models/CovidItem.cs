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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CovidItem : AbstractModel
    {
        
        /// <summary>
        /// 采样时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SampleTime")]
        public BaseItem SampleTime{ get; set; }

        /// <summary>
        /// 检测时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TestTime")]
        public BaseItem TestTime{ get; set; }

        /// <summary>
        /// 检测机构
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TestOrganization")]
        public BaseItem TestOrganization{ get; set; }

        /// <summary>
        /// 检测结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TestResult")]
        public BaseItem TestResult{ get; set; }

        /// <summary>
        /// 健康码颜色
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeColor")]
        public BaseItem CodeColor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SampleTime.", this.SampleTime);
            this.SetParamObj(map, prefix + "TestTime.", this.TestTime);
            this.SetParamObj(map, prefix + "TestOrganization.", this.TestOrganization);
            this.SetParamObj(map, prefix + "TestResult.", this.TestResult);
            this.SetParamObj(map, prefix + "CodeColor.", this.CodeColor);
        }
    }
}

