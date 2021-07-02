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

    public class ImageReport : AbstractModel
    {
        
        /// <summary>
        /// 报告文本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageText")]
        public ImageText ImageText{ get; set; }

        /// <summary>
        /// 报告类别信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KindSet")]
        public KindItem[] KindSet{ get; set; }

        /// <summary>
        /// 基本信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasicInfo")]
        public BasicInfo BasicInfo{ get; set; }

        /// <summary>
        /// 个人隐私信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PersonalInfo")]
        public PersonalInfo PersonalInfo{ get; set; }

        /// <summary>
        /// 检验指标内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TestList")]
        public TestItem[] TestList{ get; set; }

        /// <summary>
        /// 检查报告内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Inspection")]
        public Inspection Inspection{ get; set; }

        /// <summary>
        /// 病历资料内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CaseHistory")]
        public CaseHistory CaseHistory{ get; set; }

        /// <summary>
        /// 病理报告内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Pathology")]
        public Pathology Pathology{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ImageText.", this.ImageText);
            this.SetParamArrayObj(map, prefix + "KindSet.", this.KindSet);
            this.SetParamObj(map, prefix + "BasicInfo.", this.BasicInfo);
            this.SetParamObj(map, prefix + "PersonalInfo.", this.PersonalInfo);
            this.SetParamArrayObj(map, prefix + "TestList.", this.TestList);
            this.SetParamObj(map, prefix + "Inspection.", this.Inspection);
            this.SetParamObj(map, prefix + "CaseHistory.", this.CaseHistory);
            this.SetParamObj(map, prefix + "Pathology.", this.Pathology);
        }
    }
}

