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

namespace TencentCloud.Trdp.V20220726.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EvaluateUserRiskRequest : AbstractModel
    {
        
        /// <summary>
        /// 账号信息
        /// </summary>
        [JsonProperty("Account")]
        public AccountInfo Account{ get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [JsonProperty("User")]
        public UserInfo User{ get; set; }

        /// <summary>
        /// 模型ID
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 设备指纹信息
        /// </summary>
        [JsonProperty("DeviceFingerprint")]
        public DeviceFingerprintInfo DeviceFingerprint{ get; set; }

        /// <summary>
        /// 场景Code，不传默认活动防刷；
        /// e_activity_antirush；活动防刷场景
        /// e_login_protection；登录保护场景
        /// e_register_protection：注册保护场景
        /// </summary>
        [JsonProperty("SceneCode")]
        public string SceneCode{ get; set; }

        /// <summary>
        /// 设备详情
        /// </summary>
        [JsonProperty("DeviceDetail")]
        public DeviceDetailInfo DeviceDetail{ get; set; }

        /// <summary>
        /// 营销信息
        /// </summary>
        [JsonProperty("Marketing")]
        public MarketingInfo Marketing{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Account.", this.Account);
            this.SetParamObj(map, prefix + "User.", this.User);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamObj(map, prefix + "DeviceFingerprint.", this.DeviceFingerprint);
            this.SetParamSimple(map, prefix + "SceneCode", this.SceneCode);
            this.SetParamObj(map, prefix + "DeviceDetail.", this.DeviceDetail);
            this.SetParamObj(map, prefix + "Marketing.", this.Marketing);
        }
    }
}

