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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActionInfo : AbstractModel
    {
        
        /// <summary>
        /// 躯体动作识别结果，包含坐着（sit）、站立（stand）和趴睡（sleep）
        /// </summary>
        [JsonProperty("BodyPosture")]
        public ActionType BodyPosture{ get; set; }

        /// <summary>
        /// 举手识别结果，包含举手（hand）和未检测到举手（nothand）
        /// </summary>
        [JsonProperty("Handup")]
        public ActionType Handup{ get; set; }

        /// <summary>
        /// 是否低头识别结果，包含抬头（lookingahead）和未检测到抬头（notlookingahead）
        /// </summary>
        [JsonProperty("LookHead")]
        public ActionType LookHead{ get; set; }

        /// <summary>
        /// 是否写字识别结果，包含写字（write）和未检测到写字（notlookingahead）
        /// </summary>
        [JsonProperty("Writing")]
        public ActionType Writing{ get; set; }

        /// <summary>
        /// 动作图像高度
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 动作出现图像的左侧起始坐标位置
        /// </summary>
        [JsonProperty("Left")]
        public long? Left{ get; set; }

        /// <summary>
        /// 动作出现图像的上侧起始侧坐标位置
        /// </summary>
        [JsonProperty("Top")]
        public long? Top{ get; set; }

        /// <summary>
        /// 动作图像宽度
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BodyPosture.", this.BodyPosture);
            this.SetParamObj(map, prefix + "Handup.", this.Handup);
            this.SetParamObj(map, prefix + "LookHead.", this.LookHead);
            this.SetParamObj(map, prefix + "Writing.", this.Writing);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Left", this.Left);
            this.SetParamSimple(map, prefix + "Top", this.Top);
            this.SetParamSimple(map, prefix + "Width", this.Width);
        }
    }
}

