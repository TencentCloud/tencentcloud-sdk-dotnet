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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 媒资文件ID
        /// </summary>
        [JsonProperty("MediaId")]
        public string MediaId{ get; set; }

        /// <summary>
        /// 媒资素材先验知识，相关限制参考MediaPreknownInfo
        /// </summary>
        [JsonProperty("MediaPreknownInfo")]
        public MediaPreknownInfo MediaPreknownInfo{ get; set; }

        /// <summary>
        /// 任务名称，最长100个中文字符
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 是否上传转码后的视频，仅设置true时上传，默认为false
        /// </summary>
        [JsonProperty("UploadVideo")]
        public bool? UploadVideo{ get; set; }

        /// <summary>
        /// 自定义标签，可用于查询
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 任务分析完成的回调地址，该设置优先级高于控制台全局的设置；
        /// </summary>
        [JsonProperty("CallbackURL")]
        public string CallbackURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MediaId", this.MediaId);
            this.SetParamObj(map, prefix + "MediaPreknownInfo.", this.MediaPreknownInfo);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "UploadVideo", this.UploadVideo);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "CallbackURL", this.CallbackURL);
        }
    }
}

