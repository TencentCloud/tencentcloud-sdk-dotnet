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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateRotationStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 云产品凭据名称。
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// 是否开启轮转。
        /// true -- 开启轮转；
        /// false -- 禁止轮转。
        /// </summary>
        [JsonProperty("EnableRotation")]
        public bool? EnableRotation{ get; set; }

        /// <summary>
        /// 轮转周期，以天为单位，最小为30天，最大为365天。
        /// </summary>
        [JsonProperty("Frequency")]
        public long? Frequency{ get; set; }

        /// <summary>
        /// 用户设置的期望开始轮转时间，格式为：2006-01-02 15:04:05。
        /// 当EnableRotation为true时，如果不填RotationBeginTime，则默认填充为当前时间。
        /// </summary>
        [JsonProperty("RotationBeginTime")]
        public string RotationBeginTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "EnableRotation", this.EnableRotation);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "RotationBeginTime", this.RotationBeginTime);
        }
    }
}

