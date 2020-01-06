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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDatabaseACLResponse : AbstractModel
    {
        
        /// <summary>
        /// 权限标签。取值范围：
        /// <li> READONLY：所有用户可读，仅创建者和管理员可写</li>
        /// <li> PRIVATE：仅创建者及管理员可读写</li>
        /// <li> ADMINWRITE：所有用户可读，仅管理员可写</li>
        /// <li> ADMINONLY：仅管理员可读写</li>
        /// </summary>
        [JsonProperty("AclTag")]
        public string AclTag{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AclTag", this.AclTag);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

