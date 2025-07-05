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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JavaMemShellPluginInfo : AbstractModel
    {
        
        /// <summary>
        /// 注入进程pid
        /// </summary>
        [JsonProperty("Pid")]
        public ulong? Pid{ get; set; }

        /// <summary>
        /// 注入进程主类
        /// </summary>
        [JsonProperty("MainClass")]
        public string MainClass{ get; set; }

        /// <summary>
        /// 注入状态：0: 注入中, 1: 注入成功, 2: 插件超时, 3: 插件退出, 4: 注入失败 5: 软删除
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 错误日志
        /// </summary>
        [JsonProperty("ErrorLog")]
        public string ErrorLog{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "MainClass", this.MainClass);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrorLog", this.ErrorLog);
        }
    }
}

