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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFlowsByTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用相关信息。 此接口Agent.ProxyOrganizationOpenId、Agent. ProxyOperator.OpenId、Agent.AppId 和 Agent.ProxyAppId 均必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 多个合同（签署流程）信息，最多支持20个
        /// </summary>
        [JsonProperty("FlowInfos")]
        public FlowInfo[] FlowInfos{ get; set; }

        /// <summary>
        /// 是否为预览模式；默认为false，即非预览模式，此时发起合同并返回FlowIds；若为预览模式，不会发起合同，会返回PreviewUrls；
        /// 预览链接有效期300秒；
        /// 同时，如果预览的文件中指定了动态表格控件，需要进行异步合成；此时此接口返回的是合成前的文档预览链接，而合成完成后的文档预览链接会通过：回调通知的方式、或使用返回的TaskInfo中的TaskId通过ChannelGetTaskResultApi接口查询；
        /// </summary>
        [JsonProperty("NeedPreview")]
        public bool? NeedPreview{ get; set; }

        /// <summary>
        /// 预览链接类型 默认:0-文件流, 1- H5链接 注意:此参数在NeedPreview 为true 时有效,
        /// </summary>
        [JsonProperty("PreviewType")]
        public long? PreviewType{ get; set; }

        /// <summary>
        /// 操作者的信息，不用传
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArrayObj(map, prefix + "FlowInfos.", this.FlowInfos);
            this.SetParamSimple(map, prefix + "NeedPreview", this.NeedPreview);
            this.SetParamSimple(map, prefix + "PreviewType", this.PreviewType);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

