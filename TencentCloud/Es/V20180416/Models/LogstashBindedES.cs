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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogstashBindedES : AbstractModel
    {
        
        /// <summary>
        /// ES集群ID
        /// </summary>
        [JsonProperty("ESInstanceId")]
        public string ESInstanceId{ get; set; }

        /// <summary>
        /// ES集群用户名
        /// </summary>
        [JsonProperty("ESUserName")]
        public string ESUserName{ get; set; }

        /// <summary>
        /// ES集群密码
        /// </summary>
        [JsonProperty("ESPassword")]
        public string ESPassword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ESInstanceId", this.ESInstanceId);
            this.SetParamSimple(map, prefix + "ESUserName", this.ESUserName);
            this.SetParamSimple(map, prefix + "ESPassword", this.ESPassword);
        }
    }
}

