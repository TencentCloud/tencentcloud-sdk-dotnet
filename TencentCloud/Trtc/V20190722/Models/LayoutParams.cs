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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LayoutParams : AbstractModel
    {
        
        /// <summary>
        /// 混流布局模板ID，0为悬浮模板(默认);1为九宫格模板;2为屏幕分享模板
        /// </summary>
        [JsonProperty("Template")]
        public ulong? Template{ get; set; }

        /// <summary>
        /// 屏幕分享模板中有效，代表左侧大画面对应的用户ID
        /// </summary>
        [JsonProperty("MainVideoUserId")]
        public string MainVideoUserId{ get; set; }

        /// <summary>
        /// 屏幕分享模板中有效，代表左侧大画面对应的流类型，0为摄像头，1为屏幕分享
        /// </summary>
        [JsonProperty("MainVideoStreamType")]
        public ulong? MainVideoStreamType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Template", this.Template);
            this.SetParamSimple(map, prefix + "MainVideoUserId", this.MainVideoUserId);
            this.SetParamSimple(map, prefix + "MainVideoStreamType", this.MainVideoStreamType);
        }
    }
}

