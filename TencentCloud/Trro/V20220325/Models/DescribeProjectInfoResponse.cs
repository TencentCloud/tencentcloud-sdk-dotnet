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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProjectInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 项目描述
        /// </summary>
        [JsonProperty("ProjectDescription")]
        public string ProjectDescription{ get; set; }

        /// <summary>
        /// 项目权限模式，black为黑名单，white为白名单
        /// </summary>
        [JsonProperty("PolicyMode")]
        public string PolicyMode{ get; set; }

        /// <summary>
        /// 项目信息修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "ProjectDescription", this.ProjectDescription);
            this.SetParamSimple(map, prefix + "PolicyMode", this.PolicyMode);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

