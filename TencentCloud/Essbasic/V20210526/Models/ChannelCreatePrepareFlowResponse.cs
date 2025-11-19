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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelCreatePrepareFlowResponse : AbstractModel
    {
        
        /// <summary>
        /// 发起的合同嵌入链接， 可以直接点击进入进行合同发起， 有效期为5分钟
        /// </summary>
        [JsonProperty("PrepareFlowUrl")]
        public string PrepareFlowUrl{ get; set; }

        /// <summary>
        /// 合同发起后预览链接， 注意此时合同并未发起，仅只是展示效果， 有效期为5分钟
        /// </summary>
        [JsonProperty("PreviewFlowUrl")]
        public string PreviewFlowUrl{ get; set; }

        /// <summary>
        /// 发起的合同临时Id， 只有当点击进入链接，成功发起合同后， 此Id才有效
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 临时的草稿id（还未实际保存草稿），用户可以记录此字段对应后续页面保存的草稿，若在页面上未保存草稿，则此字段无效。
        /// </summary>
        [JsonProperty("DraftId")]
        public string DraftId{ get; set; }

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
            this.SetParamSimple(map, prefix + "PrepareFlowUrl", this.PrepareFlowUrl);
            this.SetParamSimple(map, prefix + "PreviewFlowUrl", this.PreviewFlowUrl);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "DraftId", this.DraftId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

