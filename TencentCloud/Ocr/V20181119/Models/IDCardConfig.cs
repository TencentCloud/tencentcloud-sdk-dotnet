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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IDCardConfig : AbstractModel
    {
        
        /// <summary>
        /// 复印件告警，默认为false
        /// </summary>
        [JsonProperty("CopyWarn")]
        public bool? CopyWarn{ get; set; }

        /// <summary>
        /// 边框和框内遮挡告警，默认为false
        /// </summary>
        [JsonProperty("BorderCheckWarn")]
        public bool? BorderCheckWarn{ get; set; }

        /// <summary>
        /// 翻拍告警，默认为false
        /// </summary>
        [JsonProperty("ReshootWarn")]
        public bool? ReshootWarn{ get; set; }

        /// <summary>
        /// 疑似存在PS痕迹告警，默认为false
        /// </summary>
        [JsonProperty("DetectPsWarn")]
        public bool? DetectPsWarn{ get; set; }

        /// <summary>
        /// 临时身份证告警，默认为false
        /// </summary>
        [JsonProperty("TempIdWarn")]
        public bool? TempIdWarn{ get; set; }

        /// <summary>
        /// 身份证有效日期不合法告警，默认为false
        /// </summary>
        [JsonProperty("InvalidDateWarn")]
        public bool? InvalidDateWarn{ get; set; }

        /// <summary>
        /// 是否开启反光检测，默认为false
        /// </summary>
        [JsonProperty("ReflectWarn")]
        public bool? ReflectWarn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CopyWarn", this.CopyWarn);
            this.SetParamSimple(map, prefix + "BorderCheckWarn", this.BorderCheckWarn);
            this.SetParamSimple(map, prefix + "ReshootWarn", this.ReshootWarn);
            this.SetParamSimple(map, prefix + "DetectPsWarn", this.DetectPsWarn);
            this.SetParamSimple(map, prefix + "TempIdWarn", this.TempIdWarn);
            this.SetParamSimple(map, prefix + "InvalidDateWarn", this.InvalidDateWarn);
            this.SetParamSimple(map, prefix + "ReflectWarn", this.ReflectWarn);
        }
    }
}

