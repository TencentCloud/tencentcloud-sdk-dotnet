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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyGroupLaneRequest : AbstractModel
    {
        
        /// <summary>
        /// 部署组ID。该参数可以通过调用 [DescribeSimpleGroups](https://cloud.tencent.com/document/product/649/36064) 的返回值中的 GroupId 字段来获取或通过登录[控制台](https://console.cloud.tencent.com/tsf/resource)-查看部署组页查看；也可以调用[CreateGroup](https://cloud.tencent.com/document/product/649/36074)创建新的部署组。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 泳道部署组列表。
        /// </summary>
        [JsonProperty("LaneList")]
        public LaneGroup[] LaneList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArrayObj(map, prefix + "LaneList.", this.LaneList);
        }
    }
}

