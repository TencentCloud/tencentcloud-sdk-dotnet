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

    public class RunCommandRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>云桌面实例ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>执行的脚本内容，编码方式由ContentEncoding指定。<br>&lt;li&gt;脚本内容在Base64编码后的大小不能超过16 KB。</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>脚本种类。取值有：&lt;li&gt;PowerShellScript Powershell脚本 &lt;li&gt;BatScript Bat脚本</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>是否同步等待脚本的执行结果。&lt;li&gt;false为异步模式，通过此接口触发任务的执行，之后异步获取执行结果。默认为false。此为推荐的模式。&lt;li&gt;true为同步等待执行结果，只有当脚本执行时间在4秒之内时，才适合将该参数置为true。如果接口返回时任务尚未执行完毕的话，也需要通过异步接口来获取执行结果。</p>
        /// </summary>
        [JsonProperty("WaitUntilDone")]
        public bool? WaitUntilDone{ get; set; }

        /// <summary>
        /// <p>Content的编码。&lt;li&gt;Base64 Base64编码。 默认为Base64</p>
        /// </summary>
        [JsonProperty("ContentEncoding")]
        public string ContentEncoding{ get; set; }

        /// <summary>
        /// <p>任务的输出内容是否合并成一个字符串。&lt;li&gt;true表示所有的输出行拼接在一起。默认为true。&lt;li&gt;false表示输出内容通过数组返回,数组的每一个元素为一行。</p>
        /// </summary>
        [JsonProperty("MergeOutputLines")]
        public bool? MergeOutputLines{ get; set; }

        /// <summary>
        /// <p>执行任务的用户ID。&lt;li&gt;由SYSTEM身份执行。此场景下不需要指定该字段，这是默认情况。&lt;li&gt;需要以绑定到实例的用户执行任务，通过该字段指定用户ID。 &lt;li&gt;匿名访问，需要以实际登录系统的用户执行的场景，该字段填实例ID。</p>
        /// </summary>
        [JsonProperty("RunAs")]
        public string RunAs{ get; set; }

        /// <summary>
        /// <p>任务是否为前台运行。仅在RunAs场景下有效。仅当任务会呼起图形界面时有意义。&lt;li&gt;true表示用户可以看到图形窗口。&lt;li&gt;false表示图形窗口不可见。默认为false。</p>
        /// </summary>
        [JsonProperty("RunForeground")]
        public bool? RunForeground{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "WaitUntilDone", this.WaitUntilDone);
            this.SetParamSimple(map, prefix + "ContentEncoding", this.ContentEncoding);
            this.SetParamSimple(map, prefix + "MergeOutputLines", this.MergeOutputLines);
            this.SetParamSimple(map, prefix + "RunAs", this.RunAs);
            this.SetParamSimple(map, prefix + "RunForeground", this.RunForeground);
        }
    }
}

