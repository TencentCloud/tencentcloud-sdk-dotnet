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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDspmAssetAccessTopologyRequest : AbstractModel
    {
        
        /// <summary>
        /// 集团账号的成员id
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// 视图类型。ip或instance
        /// </summary>
        [JsonProperty("View")]
        public string View{ get; set; }

        /// <summary>
        /// - 来源ip方式查看
        /// View: "ip"
        /// 
        /// Filter:{
        /// 	{
        /// 		"Name":"Ip",
        /// 		"Values":["172.1.1.1"]
        /// 	},
        /// 	{
        /// 		"Name":"AssetId",
        /// 		"Values":["cdb-1111|ap-guangzhou","cdb-2222|ap-guangzhou","cdb-3333|ap-guangzhou"]
        /// 	},
        /// 	{
        /// 		"Name":"Account",
        /// 		"Values":["root|%","test|%"]
        /// 	}
        /// }
        /// 
        /// 
        /// - 实例方式查看
        /// View: "instance"
        /// 
        /// Filter:{
        /// 	{
        /// 		"Name":"AssetId",
        /// 		"Values":["cdb-1111|ap-guangzhou"]
        /// 	},
        /// 	{
        /// 		"Name":"Ip",
        /// 		"Values":["172.1.1.1","172.1.1.2","172.1.1.3"]
        /// 	},
        /// 	{
        /// 		"Name":"Account",
        /// 		"Values":["root|%","test|%"]
        /// 	}
        /// }
        /// </summary>
        [JsonProperty("Filter")]
        public Filter Filter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "View", this.View);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
        }
    }
}

