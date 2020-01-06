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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MixStream : AbstractModel
    {
        
        /// <summary>
        /// 是否开启混流
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 是否禁用音频混流
        /// </summary>
        [JsonProperty("DisableAudio")]
        public bool? DisableAudio{ get; set; }

        /// <summary>
        /// 内置混流布局模板ID, 取值 [1, 2], 区别见内置混流布局模板样式示例说明
        /// 在没有填Custom字段时候，ModelId是必填的
        /// </summary>
        [JsonProperty("ModelId")]
        public long? ModelId{ get; set; }

        /// <summary>
        /// 老师用户ID
        /// 此字段只有在ModelId填了的情况下生效
        /// 填写TeacherId的效果是把指定为TeacherId的用户视频流显示在内置模板的第一个小画面中
        /// </summary>
        [JsonProperty("TeacherId")]
        public string TeacherId{ get; set; }

        /// <summary>
        /// 自定义混流布局参数
        /// 当此字段存在时，ModelId 及 TeacherId 字段将被忽略
        /// </summary>
        [JsonProperty("Custom")]
        public CustomLayout Custom{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "DisableAudio", this.DisableAudio);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "TeacherId", this.TeacherId);
            this.SetParamObj(map, prefix + "Custom.", this.Custom);
        }
    }
}

