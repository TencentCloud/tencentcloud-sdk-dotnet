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

    public class CreateDocumentResponse : AbstractModel
    {
        
        /// <summary>
        /// 合同流程的底层电子文档ID，为32位字符串。
        /// 
        /// 注:
        /// 后续需用同样的FlowId再次调用[发起签署流程](https://qian.tencent.com/developers/companyApis/startFlows/StartFlow)，合同才能进入签署环节
        /// </summary>
        [JsonProperty("DocumentId")]
        public string DocumentId{ get; set; }

        /// <summary>
        /// 合同预览链接URL。
        /// 
        /// 注: `1.如果是预览模式(即NeedPreview设置为true)时, 才会有此预览链接URL`
        /// `2.当使用的模板中存在动态表格控件时，预览结果中没有动态表格的填写内容`
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreviewFileUrl")]
        public string PreviewFileUrl{ get; set; }

        /// <summary>
        /// 签署方信息，如角色ID、角色名称等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Approvers")]
        public ApproverItem[] Approvers{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DocumentId", this.DocumentId);
            this.SetParamSimple(map, prefix + "PreviewFileUrl", this.PreviewFileUrl);
            this.SetParamArrayObj(map, prefix + "Approvers.", this.Approvers);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

