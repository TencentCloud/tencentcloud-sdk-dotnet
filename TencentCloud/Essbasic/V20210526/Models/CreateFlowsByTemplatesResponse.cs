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

    public class CreateFlowsByTemplatesResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>生成的合同流程ID数组，合同流程ID为32位字符串。<br>建议开发者妥善保存此流程ID数组，以便于顺利进行后续操作。</p><p><a href="https://qcloudimg.tencent-cloud.cn/raw/05af26573d5106763b4cfbb9f7c64b41.png">点击产看FlowId在控制台上的位置</a></p>
        /// </summary>
        [JsonProperty("FlowIds")]
        public string[] FlowIds{ get; set; }

        /// <summary>
        /// <p>第三方应用平台的业务信息, 与创建合同的FlowInfos数组中的CustomerData一一对应</p>
        /// </summary>
        [JsonProperty("CustomerData")]
        public string[] CustomerData{ get; set; }

        /// <summary>
        /// <p>创建消息，对应多个合同ID，<br>成功为“”,创建失败则对应失败消息</p>
        /// </summary>
        [JsonProperty("ErrorMessages")]
        public string[] ErrorMessages{ get; set; }

        /// <summary>
        /// <p>合同预览链接URL数组。</p><p>注：如果是预览模式(即NeedPreview设置为true)时, 才会有此预览链接URL<br>如果预览的文件中指定了动态表格控件，此时此接口返回的是合成前的文档预览链接，合成完成后的文档预览链接需要通过<a href="https://qian.tencent.com/developers/partner/callback_types_contracts_sign#%E5%8D%81%E4%B8%80-%E5%90%88%E5%90%8C%E6%96%87%E6%A1%A3%E5%90%88%E6%88%90%E5%AE%8C%E6%88%90%E5%9B%9E%E8%B0%83">合同文档合成完成回调</a>获取或使用返回的TaskInfo中的TaskId通过<a href="https://qian.tencent.com/developers/partnerApis/files/ChannelGetTaskResultApi">查询转换任务状态</a>接口查询得到</p>
        /// </summary>
        [JsonProperty("PreviewUrls")]
        public string[] PreviewUrls{ get; set; }

        /// <summary>
        /// <p>复杂文档合成任务（如，包含动态表格的预览任务）的任务信息数组；<br>如果文档需要异步合成，此字段会返回该异步任务的任务信息，后续可以通过ChannelGetTaskResultApi接口查询任务详情；</p>
        /// </summary>
        [JsonProperty("TaskInfos")]
        public TaskInfo[] TaskInfos{ get; set; }

        /// <summary>
        /// <p>签署方信息，如角色ID、角色名称等</p>
        /// </summary>
        [JsonProperty("FlowApprovers")]
        public FlowApproverItem[] FlowApprovers{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "FlowIds.", this.FlowIds);
            this.SetParamArraySimple(map, prefix + "CustomerData.", this.CustomerData);
            this.SetParamArraySimple(map, prefix + "ErrorMessages.", this.ErrorMessages);
            this.SetParamArraySimple(map, prefix + "PreviewUrls.", this.PreviewUrls);
            this.SetParamArrayObj(map, prefix + "TaskInfos.", this.TaskInfos);
            this.SetParamArrayObj(map, prefix + "FlowApprovers.", this.FlowApprovers);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

