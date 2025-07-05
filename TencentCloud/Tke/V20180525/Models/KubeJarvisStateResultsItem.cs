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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KubeJarvisStateResultsItem : AbstractModel
    {
        
        /// <summary>
        /// 诊断结果级别
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 诊断对象名
        /// </summary>
        [JsonProperty("ObjName")]
        public string ObjName{ get; set; }

        /// <summary>
        /// 诊断对象信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjInfo")]
        public KubeJarvisStateResultObjInfo[] ObjInfo{ get; set; }

        /// <summary>
        /// 诊断项标题
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 诊断项描述
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 诊断建议
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Proposal")]
        public string Proposal{ get; set; }

        /// <summary>
        /// 诊断建议文档链接
        /// </summary>
        [JsonProperty("ProposalDocUrl")]
        public string ProposalDocUrl{ get; set; }

        /// <summary>
        /// 诊断建议文档名称
        /// </summary>
        [JsonProperty("ProposalDocName")]
        public string ProposalDocName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "ObjName", this.ObjName);
            this.SetParamArrayObj(map, prefix + "ObjInfo.", this.ObjInfo);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Proposal", this.Proposal);
            this.SetParamSimple(map, prefix + "ProposalDocUrl", this.ProposalDocUrl);
            this.SetParamSimple(map, prefix + "ProposalDocName", this.ProposalDocName);
        }
    }
}

