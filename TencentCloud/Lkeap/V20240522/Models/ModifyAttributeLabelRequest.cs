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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAttributeLabelRequest : AbstractModel
    {
        
        /// <summary>
        /// 说明：知识库ID
        /// 备注：通过创建知识库接口（DeleteKnowledgeBase）得到知识库ID（KnowledgeBaseId）
        /// </summary>
        [JsonProperty("KnowledgeBaseId")]
        public string KnowledgeBaseId{ get; set; }

        /// <summary>
        /// 说明：属性ID
        /// 备注：通过CreateAttributeLabel接口创建属性时会生成AttributeId，通过ListAttributeLabels接口可查询得到AttributeId、AttributeKey、AttributeName以及LabelId、LabelName的对应关系
        /// </summary>
        [JsonProperty("AttributeId")]
        public string AttributeId{ get; set; }

        /// <summary>
        /// 说明：属性标识，
        /// 备注：仅支持英文字符，不支持数字，支持下划线。最大支持40个英文字符，如style
        /// </summary>
        [JsonProperty("AttributeKey")]
        public string AttributeKey{ get; set; }

        /// <summary>
        /// 说明：属性名称
        /// 备注：支持中英文字符。最大支持80个中英文字符，如风格
        /// </summary>
        [JsonProperty("AttributeName")]
        public string AttributeName{ get; set; }

        /// <summary>
        /// 说明：标签ID（LabelId）以及标签名（LabelName）
        /// 备注：
        /// - 不填写LabelId，默认在当前AttributeId下新增标签值（LabelName）；
        /// - 若填写该AttributeId下的LabelId以及LabelName，则为修改该LabelId对应的标签值
        /// </summary>
        [JsonProperty("Labels")]
        public AttributeLabelItem[] Labels{ get; set; }

        /// <summary>
        /// 说明：删除的标签id
        /// </summary>
        [JsonProperty("DeleteLabelIds")]
        public string[] DeleteLabelIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KnowledgeBaseId", this.KnowledgeBaseId);
            this.SetParamSimple(map, prefix + "AttributeId", this.AttributeId);
            this.SetParamSimple(map, prefix + "AttributeKey", this.AttributeKey);
            this.SetParamSimple(map, prefix + "AttributeName", this.AttributeName);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArraySimple(map, prefix + "DeleteLabelIds.", this.DeleteLabelIds);
        }
    }
}

