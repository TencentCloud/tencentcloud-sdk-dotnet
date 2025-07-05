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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchProcessMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// 媒体处理的文件输入信息。
        /// </summary>
        [JsonProperty("InputInfo")]
        public MediaInputInfo[] InputInfo{ get; set; }

        /// <summary>
        /// 媒体处理输出文件的目标存储。不填则继承 InputInfo 中的存储位置。
        /// 注意：当InputInfo.Type为URL时，该参数是必填项
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// 媒体处理生成的文件输出的目标目录，必选以 / 开头和结尾，如`/movie/201907/`。
        /// 如果不填，表示与 InputInfo 中文件所在的目录一致。
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }

        /// <summary>
        /// 智能字幕
        /// </summary>
        [JsonProperty("SmartSubtitlesTask")]
        public SmartSubtitlesTaskInput SmartSubtitlesTask{ get; set; }

        /// <summary>
        /// 任务的事件通知信息，不填代表不获取事件通知。
        /// </summary>
        [JsonProperty("TaskNotifyConfig")]
        public TaskNotifyConfig TaskNotifyConfig{ get; set; }

        /// <summary>
        /// 任务流的优先级，数值越大优先级越高，取值范围是-10到 10，不填代表0。
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// 来源上下文，用于透传用户请求信息，任务流状态变更回调将返回该字段值，最长 1000 个字符。
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// 资源ID，需要保证对应资源是开启状态。默认为帐号主资源ID。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 是否跳过元信息获取，可选值： 
        /// 0：表示不跳过 
        /// 1：表示跳过 
        /// 默认值：0	
        /// </summary>
        [JsonProperty("SkipMateData")]
        public long? SkipMateData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputDir", this.OutputDir);
            this.SetParamObj(map, prefix + "SmartSubtitlesTask.", this.SmartSubtitlesTask);
            this.SetParamObj(map, prefix + "TaskNotifyConfig.", this.TaskNotifyConfig);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "SkipMateData", this.SkipMateData);
        }
    }
}

