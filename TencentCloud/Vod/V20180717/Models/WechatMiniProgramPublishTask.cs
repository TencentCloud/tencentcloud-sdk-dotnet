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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WechatMiniProgramPublishTask : AbstractModel
    {
        
        /// <summary>
        /// 任务 ID。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务状态，取值：
        /// WAITING：等待中；
        /// PROCESSING：处理中；
        /// FINISH：已完成。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 错误码
        /// <li>0：成功；</li>
        /// <li>其他值：失败。</li>
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 发布视频文件 ID。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 发布视频所对应的转码模板 ID，为 0 代表原始视频。
        /// </summary>
        [JsonProperty("SourceDefinition")]
        public ulong? SourceDefinition{ get; set; }

        /// <summary>
        /// 微信小程序视频发布状态，取值：
        /// <li>Pass：发布成功；</li>
        /// <li>Failed：发布失败；</li>
        /// <li>Rejected：审核未通过。</li>
        /// </summary>
        [JsonProperty("PublishResult")]
        public string PublishResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "SourceDefinition", this.SourceDefinition);
            this.SetParamSimple(map, prefix + "PublishResult", this.PublishResult);
        }
    }
}

