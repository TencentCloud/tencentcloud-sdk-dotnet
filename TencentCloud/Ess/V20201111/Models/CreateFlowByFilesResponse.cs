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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFlowByFilesResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>合同流程ID，为32位字符串。<br>建议开发者妥善保存此流程ID，以便于顺利进行后续操作。</p><p>注: 如果是预览模式(即NeedPreview设置为true)时, 此处不会有值返回。</p><p><a href="https://qcloudimg.tencent-cloud.cn/raw/0a83015166cfe1cb043d14f9ec4bd75e.png">点击查看FlowId在控制台中的位置</a></p>
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// <p>合同预览链接URL。</p><p>注：如果是预览模式(即NeedPreview设置为true)时, 才会有此预览链接URL</p>
        /// </summary>
        [JsonProperty("PreviewUrl")]
        public string PreviewUrl{ get; set; }

        /// <summary>
        /// <p>签署方信息，如角色ID、角色名称等</p>
        /// </summary>
        [JsonProperty("Approvers")]
        public ApproverItem[] Approvers{ get; set; }

        /// <summary>
        /// <p>发起审批流id，仅在CreateFlowByFiles时指定了WorkFlow=true时返回</p>
        /// </summary>
        [JsonProperty("WorkflowInstanceId")]
        public string WorkflowInstanceId{ get; set; }

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
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "PreviewUrl", this.PreviewUrl);
            this.SetParamArrayObj(map, prefix + "Approvers.", this.Approvers);
            this.SetParamSimple(map, prefix + "WorkflowInstanceId", this.WorkflowInstanceId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

