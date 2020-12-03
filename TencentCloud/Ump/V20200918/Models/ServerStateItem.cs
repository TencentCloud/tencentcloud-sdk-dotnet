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

namespace TencentCloud.Ump.V20200918.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerStateItem : AbstractModel
    {
        
        /// <summary>
        /// 服务器状态
        /// 1: 在线
        /// 2: 离线
        /// 3: 重启
        /// </summary>
        [JsonProperty("ServerState")]
        public long? ServerState{ get; set; }

        /// <summary>
        /// 服务器IP
        /// </summary>
        [JsonProperty("ServerIp")]
        public string ServerIp{ get; set; }

        /// <summary>
        /// 硬盘监控信息列表
        /// </summary>
        [JsonProperty("DiskInfos")]
        public DiskInfo[] DiskInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServerState", this.ServerState);
            this.SetParamSimple(map, prefix + "ServerIp", this.ServerIp);
            this.SetParamArrayObj(map, prefix + "DiskInfos.", this.DiskInfos);
        }
    }
}

