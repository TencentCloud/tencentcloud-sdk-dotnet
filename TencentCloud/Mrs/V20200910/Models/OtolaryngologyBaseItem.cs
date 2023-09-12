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

    public class OtolaryngologyBaseItem : AbstractModel
    {
        
        /// <summary>
        /// 耳朵
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ear")]
        public OtolaryngologyEar Ear{ get; set; }

        /// <summary>
        /// 鼻
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nose")]
        public OtolaryngologyNose Nose{ get; set; }

        /// <summary>
        /// 喉
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Larynx")]
        public OtolaryngologyLarynx Larynx{ get; set; }

        /// <summary>
        /// 耳鼻喉其他
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Others")]
        public KeyValueItem[] Others{ get; set; }

        /// <summary>
        /// 小结
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BriefSummary")]
        public OtolaryngologyBriefSummary BriefSummary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Ear.", this.Ear);
            this.SetParamObj(map, prefix + "Nose.", this.Nose);
            this.SetParamObj(map, prefix + "Larynx.", this.Larynx);
            this.SetParamArrayObj(map, prefix + "Others.", this.Others);
            this.SetParamObj(map, prefix + "BriefSummary.", this.BriefSummary);
        }
    }
}

