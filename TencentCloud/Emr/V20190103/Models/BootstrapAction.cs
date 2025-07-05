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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BootstrapAction : AbstractModel
    {
        
        /// <summary>
        /// 脚本位置，支持cos上的文件，且只支持https协议。
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 执行时间。
        /// resourceAfter 表示在机器资源申请成功后执行。
        /// clusterBefore 表示在集群初始化前执行。
        /// clusterAfter 表示在集群初始化后执行。
        /// </summary>
        [JsonProperty("WhenRun")]
        public string WhenRun{ get; set; }

        /// <summary>
        /// 脚本参数
        /// </summary>
        [JsonProperty("Args")]
        public string[] Args{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "WhenRun", this.WhenRun);
            this.SetParamArraySimple(map, prefix + "Args.", this.Args);
        }
    }
}

