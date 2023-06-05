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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisableUserAutoSignRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作人信息,UserId必填
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 自动签场景:
        /// E_PRESCRIPTION_AUTO_SIGN 电子处方
        /// </summary>
        [JsonProperty("SceneKey")]
        public string SceneKey{ get; set; }

        /// <summary>
        /// 关闭自动签的个人的三要素
        /// </summary>
        [JsonProperty("UserInfo")]
        public UserThreeFactor UserInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "SceneKey", this.SceneKey);
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
        }
    }
}

