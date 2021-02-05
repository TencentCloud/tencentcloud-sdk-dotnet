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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TerminateInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 待销毁的实例ID列表。
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// 是否定时销毁，默认为否。
        /// </summary>
        [JsonProperty("TerminateDelay")]
        public bool? TerminateDelay{ get; set; }

        /// <summary>
        /// 定时销毁的时间，格式形如："2019-08-05 12:01:30"，若非定时销毁，则此参数被忽略。
        /// </summary>
        [JsonProperty("TerminateTime")]
        public string TerminateTime{ get; set; }

        /// <summary>
        /// 是否关联删除已绑定的弹性网卡和弹性IP，默认为true。
        /// 当为true时，一并删除弹性网卡和弹性IP；
        /// 当为false时，只销毁主机，保留弹性网卡和弹性IP。
        /// </summary>
        [JsonProperty("AssociatedResourceDestroy")]
        public bool? AssociatedResourceDestroy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIdSet.", this.InstanceIdSet);
            this.SetParamSimple(map, prefix + "TerminateDelay", this.TerminateDelay);
            this.SetParamSimple(map, prefix + "TerminateTime", this.TerminateTime);
            this.SetParamSimple(map, prefix + "AssociatedResourceDestroy", this.AssociatedResourceDestroy);
        }
    }
}

