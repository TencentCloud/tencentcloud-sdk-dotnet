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

    public class ChannelGetTaskResultApiResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务状态，需要关注的状态
        /// <ul><li>**0**  :NeedTranform   - 任务已提交</li>
        /// <li>**4**  :Processing     - 文档转换中</li>
        /// <li>**8**  :TaskEnd        - 任务处理完成</li>
        /// <li>**-2** :DownloadFailed - 下载失败</li>
        /// <li>**-6** :ProcessFailed  - 转换失败</li>
        /// <li>**-13**:ProcessTimeout - 转换文件超时</li></ul>
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// 状态描述，需要关注的状态
        /// <ul><li> **NeedTranform** : 任务已提交</li>
        /// <li> **Processing** : 文档转换中</li>
        /// <li> **TaskEnd** : 任务处理完成</li>
        /// <li> **DownloadFailed** : 下载失败</li>
        /// <li> **ProcessFailed** : 转换失败</li>
        /// <li> **ProcessTimeout** : 转换文件超时</li></ul>
        /// </summary>
        [JsonProperty("TaskMessage")]
        public string TaskMessage{ get; set; }

        /// <summary>
        /// 资源Id（即FileId），用于[用PDF文件创建签署流程](https://qian.tencent.com/developers/partnerApis/startFlows/ChannelCreateFlowByFiles)
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 预览文件Url，有效期30分钟 
        /// 当前字段返回为空，发起的时候，将ResourceId 放入发起即可
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreviewUrl")]
        [System.Obsolete]
        public string PreviewUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskMessage", this.TaskMessage);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "PreviewUrl", this.PreviewUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

