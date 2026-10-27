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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceFetchMsgRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 绑定实例的UserID，为后续多会话预留参数
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 拉取桌面title，用户可自行定义，默认为云桌面实例名称
        /// </summary>
        [JsonProperty("DesktopName")]
        public string DesktopName{ get; set; }

        /// <summary>
        /// 是否抢占桌面，即桌面使用过程中，抢占登录。
        /// true：抢占登录
        /// false：非抢占登录
        /// 默认为抢占登录
        /// </summary>
        [JsonProperty("Force")]
        public bool? Force{ get; set; }

        /// <summary>
        /// 是否内网登录桌面
        /// </summary>
        [JsonProperty("IsInternal")]
        public bool? IsInternal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "DesktopName", this.DesktopName);
            this.SetParamSimple(map, prefix + "Force", this.Force);
            this.SetParamSimple(map, prefix + "IsInternal", this.IsInternal);
        }
    }
}

