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

namespace TencentCloud.Ciam.V20220331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateUserStoreRequest : AbstractModel
    {
        
        /// <summary>
        /// 用户池ID
        /// </summary>
        [JsonProperty("UserPoolId")]
        public string UserPoolId{ get; set; }

        /// <summary>
        /// 用户池名字
        /// </summary>
        [JsonProperty("UserPoolName")]
        public string UserPoolName{ get; set; }

        /// <summary>
        /// 用户池描述
        /// </summary>
        [JsonProperty("UserPoolDesc")]
        public string UserPoolDesc{ get; set; }

        /// <summary>
        /// 用户池logo
        /// </summary>
        [JsonProperty("UserPoolLogo")]
        public string UserPoolLogo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserPoolId", this.UserPoolId);
            this.SetParamSimple(map, prefix + "UserPoolName", this.UserPoolName);
            this.SetParamSimple(map, prefix + "UserPoolDesc", this.UserPoolDesc);
            this.SetParamSimple(map, prefix + "UserPoolLogo", this.UserPoolLogo);
        }
    }
}

