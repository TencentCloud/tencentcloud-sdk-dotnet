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

    public class SurgeryAnorectal : AbstractModel
    {
        
        /// <summary>
        /// 肛门直肠总体描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Text")]
        public KeyValueItem Text{ get; set; }

        /// <summary>
        /// 直肠指检
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DigitalRectalExamination")]
        public KeyValueItem DigitalRectalExamination{ get; set; }

        /// <summary>
        /// 痔疮
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Hemorrhoid")]
        public KeyValueItem Hemorrhoid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Text.", this.Text);
            this.SetParamObj(map, prefix + "DigitalRectalExamination.", this.DigitalRectalExamination);
            this.SetParamObj(map, prefix + "Hemorrhoid.", this.Hemorrhoid);
        }
    }
}

