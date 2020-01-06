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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteListenersResponse : AbstractModel
    {
        
        /// <summary>
        /// 删除操作失败的监听器ID列表
        /// </summary>
        [JsonProperty("OperationFailedListenerSet")]
        public string[] OperationFailedListenerSet{ get; set; }

        /// <summary>
        /// 删除操作成功的监听器ID列表
        /// </summary>
        [JsonProperty("OperationSucceedListenerSet")]
        public string[] OperationSucceedListenerSet{ get; set; }

        /// <summary>
        /// 无效的监听器ID列表，如：监听器不存在，监听器对应实例不匹配
        /// </summary>
        [JsonProperty("InvalidStatusListenerSet")]
        public string[] InvalidStatusListenerSet{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "OperationFailedListenerSet.", this.OperationFailedListenerSet);
            this.SetParamArraySimple(map, prefix + "OperationSucceedListenerSet.", this.OperationSucceedListenerSet);
            this.SetParamArraySimple(map, prefix + "InvalidStatusListenerSet.", this.InvalidStatusListenerSet);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

