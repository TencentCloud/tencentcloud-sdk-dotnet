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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyMigrateRuntimeAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 迁移任务id，如：dts-2rgv0f09
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 需要修改的属性，此结构设计为通用结构，用于屏蔽多个业务的定制属性。<br>例如对于Redis:<br>{<br>	 "Key": "DstWriteMode",	//目标库写入模式<br> 	"Value": "normal"	          //clearData(清空目标实例数据)、overwrite(以覆盖写的方式执行任务)、normal(跟正常流程一样，不做额外动作，默认为此值) <br>},<br>{<br/>	 "Key": "IsDstReadOnly",	//是否在迁移时设置目标库只读<br/> 	"Value": "true"	          //true(设置只读)、false(不设置只读) <br/>} 
        /// </summary>
        [JsonProperty("OtherOptions")]
        public KeyValuePairOption[] OtherOptions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamArrayObj(map, prefix + "OtherOptions.", this.OtherOptions);
        }
    }
}

