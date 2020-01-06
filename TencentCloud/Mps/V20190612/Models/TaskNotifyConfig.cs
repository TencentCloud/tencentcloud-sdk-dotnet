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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskNotifyConfig : AbstractModel
    {
        
        /// <summary>
        /// CMQ 的模型，有 Queue 和 Topic 两种，目前仅支持 Queue。
        /// </summary>
        [JsonProperty("CmqModel")]
        public string CmqModel{ get; set; }

        /// <summary>
        /// CMQ 的园区，如 sh，bj 等。
        /// </summary>
        [JsonProperty("CmqRegion")]
        public string CmqRegion{ get; set; }

        /// <summary>
        /// 当模型为 Queue 时有效，表示接收事件通知的 CMQ 的队列名。
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// 当模型为 Topic 时有效，表示接收事件通知的 CMQ 的主题名。
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 工作流通知的模式，可取值有 Finish 和 Change，不填代表 Finish。
        /// </summary>
        [JsonProperty("NotifyMode")]
        public string NotifyMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CmqModel", this.CmqModel);
            this.SetParamSimple(map, prefix + "CmqRegion", this.CmqRegion);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "NotifyMode", this.NotifyMode);
        }
    }
}

