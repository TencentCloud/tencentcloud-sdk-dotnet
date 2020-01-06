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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ObjectConfigureInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// 物体识别任务开关，可选值：
        /// <li>ON：开启智能物体识别任务；</li>
        /// <li>OFF：关闭智能物体识别任务。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 物体库选择，可选值：
        /// <li>Default：使用默认物体库；</li>
        /// <li>UserDefine：使用用户自定义物体库。</li>
        /// <li>All：同时使用默认物体库和用户自定义物体库。</li>
        /// </summary>
        [JsonProperty("ObjectLibrary")]
        public string ObjectLibrary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "ObjectLibrary", this.ObjectLibrary);
        }
    }
}

