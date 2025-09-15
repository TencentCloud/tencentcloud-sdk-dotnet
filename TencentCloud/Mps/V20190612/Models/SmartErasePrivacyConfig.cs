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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmartErasePrivacyConfig : AbstractModel
    {
        
        /// <summary>
        /// 隐私保护擦除方式。
        /// - blur 模糊
        /// - mosaic 马赛克
        /// </summary>
        [JsonProperty("PrivacyModel")]
        public string PrivacyModel{ get; set; }

        /// <summary>
        /// 隐私保护目标，（在API Explorer上使用时无需传入数组，添加相应项并填入对应值即可）。
        /// - face 人脸
        /// - plate 车牌
        /// </summary>
        [JsonProperty("PrivacyTargets")]
        public string[] PrivacyTargets{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrivacyModel", this.PrivacyModel);
            this.SetParamArraySimple(map, prefix + "PrivacyTargets.", this.PrivacyTargets);
        }
    }
}

