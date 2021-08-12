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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceData : AbstractModel
    {
        
        /// <summary>
        /// 资源名称，根据查询条件不同分为以下几类：
        /// 单域名：指定单域名查询，表示该域名明细数据，当传入参数 detail 指定为 true 时，显示该域名（ detail 参数默认为 false ）
        /// 多域名：指定多个域名查询，表示多域名汇总明细数据，显示 multiDomains
        /// 项目 ID：指定项目查询时，表示该项目下的域名汇总明细数据，显示该项目 ID
        /// all：账号维度明细数据，即账号下所有域名的汇总明细数据
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// 资源对应的数据明细
        /// </summary>
        [JsonProperty("CdnData")]
        public CdnData[] CdnData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamArrayObj(map, prefix + "CdnData.", this.CdnData);
        }
    }
}

