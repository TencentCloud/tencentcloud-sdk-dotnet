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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputRedirect : AbstractModel
    {
        
        /// <summary>
        /// <p>输出driver类型</p><p>枚举值：</p><ul><li>local： 宿主机本地目录</li><li>cos： 远端cos存储</li></ul><p>默认值：local</p>
        /// </summary>
        [JsonProperty("Driver")]
        public string Driver{ get; set; }

        /// <summary>
        /// <p>重定向配置参数</p><p>日志重定向路径，用于指定任务日志的输出目标。取值格式与 Driver 类型关联：<br>当 Driver 为 local 时，格式为本地文件路径，如 stdout=/tmp/train_out.log；<br>当 Driver 为 cos 时，格式为 COS 存储桶路径，如 stdout=cos://test-123456.cos.ap-shanghai.myqcloud.com/test/.</p>
        /// </summary>
        [JsonProperty("Options")]
        public string[] Options{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Driver", this.Driver);
            this.SetParamArraySimple(map, prefix + "Options.", this.Options);
        }
    }
}

