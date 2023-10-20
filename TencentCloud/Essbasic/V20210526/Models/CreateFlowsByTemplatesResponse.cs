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

    public class CreateFlowsByTemplatesResponse : AbstractModel
    {
        
        /// <summary>
        /// 生成的合同流程ID数组，合同流程ID为32位字符串。
        /// 建议开发者妥善保存此流程ID数组，以便于顺利进行后续操作。
        /// </summary>
        [JsonProperty("FlowIds")]
        public string[] FlowIds{ get; set; }

        /// <summary>
        /// 第三方应用平台的业务信息, 与创建合同的FlowInfos数组中的CustomerData一一对应
        /// </summary>
        [JsonProperty("CustomerData")]
        public string[] CustomerData{ get; set; }

        /// <summary>
        /// 创建消息，对应多个合同ID，
        /// 成功为“”,创建失败则对应失败消息
        /// </summary>
        [JsonProperty("ErrorMessages")]
        public string[] ErrorMessages{ get; set; }

        /// <summary>
        /// 合同预览链接URL数组。
        /// 
        /// 注：如果是预览模式(即NeedPreview设置为true)时, 才会有此预览链接URL
        /// </summary>
        [JsonProperty("PreviewUrls")]
        public string[] PreviewUrls{ get; set; }

        /// <summary>
        /// 复杂文档合成任务（如，包含动态表格的预览任务）的任务信息数组；
        /// 如果文档需要异步合成，此字段会返回该异步任务的任务信息，后续可以通过ChannelGetTaskResultApi接口查询任务详情；
        /// </summary>
        [JsonProperty("TaskInfos")]
        public TaskInfo[] TaskInfos{ get; set; }

        /// <summary>
        /// 签署方信息，如角色ID、角色名称等
        /// </summary>
        [JsonProperty("FlowApprovers")]
        public FlowApproverItem[] FlowApprovers{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
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

