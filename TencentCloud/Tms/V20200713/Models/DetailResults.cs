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

namespace TencentCloud.Tms.V20200713.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetailResults : AbstractModel
    {
        
        /// <summary>
        /// 恶意标签，Normal：正常，Polity：涉政，Porn：色情，Illegal：违法，Abuse：谩骂，Terror：暴恐，Ad：广告，Custom：自定义关键词
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 建议值,Block：打击,Review：待复审,Pass：正常
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 该标签下命中的关键词
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// 该标签模型命中的分值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// 仅当Lable为Custom自定义关键词时有效，表示自定义关键词库类型，1:黑白库，2：自定义库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LibType")]
        public long? LibType{ get; set; }

        /// <summary>
        /// 仅当Lable为Custom自定义关键词时有效，表示自定义库id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LibId")]
        public string LibId{ get; set; }

        /// <summary>
        /// 仅当Lable为Custom自定义关键词时有效，表示自定义库名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LibName")]
        public string LibName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "LibType", this.LibType);
            this.SetParamSimple(map, prefix + "LibId", this.LibId);
            this.SetParamSimple(map, prefix + "LibName", this.LibName);
        }
    }
}

