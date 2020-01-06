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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateScanInstancesResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务唯一标识
        /// </summary>
        [JsonProperty("ItemId")]
        public string ItemId{ get; set; }

        /// <summary>
        /// 任务状态: 1-已完成,2-处理中,3-处理出错,4-处理超时
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// 提交成功的app的md5集合
        /// </summary>
        [JsonProperty("AppMd5s")]
        public string[] AppMd5s{ get; set; }

        /// <summary>
        /// 剩余可用次数
        /// </summary>
        [JsonProperty("LimitCount")]
        public ulong? LimitCount{ get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("LimitTime")]
        public ulong? LimitTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamArraySimple(map, prefix + "AppMd5s.", this.AppMd5s);
            this.SetParamSimple(map, prefix + "LimitCount", this.LimitCount);
            this.SetParamSimple(map, prefix + "LimitTime", this.LimitTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

