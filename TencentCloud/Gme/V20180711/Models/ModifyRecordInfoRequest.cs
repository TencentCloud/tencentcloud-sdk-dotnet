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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRecordInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>进行中的任务taskid（StartRecord接口返回）。</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// <p>录制类型：1代表单流 2代表混流 3代表单流和混流。</p>
        /// </summary>
        [JsonProperty("RecordMode")]
        public ulong? RecordMode{ get; set; }

        /// <summary>
        /// <p>应用ID。</p>
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }

        /// <summary>
        /// <p>指定订阅流白名单或者黑名单。</p>
        /// </summary>
        [JsonProperty("SubscribeRecordUserIds")]
        public SubscribeRecordUserIds SubscribeRecordUserIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "RecordMode", this.RecordMode);
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamObj(map, prefix + "SubscribeRecordUserIds.", this.SubscribeRecordUserIds);
        }
    }
}

