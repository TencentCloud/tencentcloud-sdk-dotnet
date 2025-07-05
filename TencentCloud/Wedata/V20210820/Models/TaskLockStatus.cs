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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskLockStatus : AbstractModel
    {
        
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 持锁者
        /// </summary>
        [JsonProperty("Locker")]
        public string Locker{ get; set; }

        /// <summary>
        /// 当前操作用户是否为持锁者，1表示为持锁者，0表示为不为持锁者
        /// </summary>
        [JsonProperty("IsLocker")]
        public long? IsLocker{ get; set; }

        /// <summary>
        /// 是否可以抢锁，1表示可以抢锁，0表示不可以抢锁
        /// </summary>
        [JsonProperty("IsRob")]
        public long? IsRob{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Locker", this.Locker);
            this.SetParamSimple(map, prefix + "IsLocker", this.IsLocker);
            this.SetParamSimple(map, prefix + "IsRob", this.IsRob);
        }
    }
}

