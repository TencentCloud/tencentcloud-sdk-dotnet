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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigrateOption : AbstractModel
    {
        
        /// <summary>
        /// 迁移对象选项，需要告知迁移服务迁移哪些库表对象
        /// </summary>
        [JsonProperty("DatabaseTable")]
        public DatabaseTableObject DatabaseTable{ get; set; }

        /// <summary>
        /// 迁移类型，full(全量迁移)，structure(结构迁移)，fullAndIncrement(全量加增量迁移)， 默认为fullAndIncrement;注意redis,keewidb产品只支持fullAndIncrement类型。
        /// </summary>
        [JsonProperty("MigrateType")]
        public string MigrateType{ get; set; }

        /// <summary>
        /// 数据一致性校验选项， 默认为不开启一致性校验
        /// </summary>
        [JsonProperty("Consistency")]
        public ConsistencyOption Consistency{ get; set; }

        /// <summary>
        /// 是否迁移账号，true(迁移账号)，false(不迁移账号)
        /// </summary>
        [JsonProperty("IsMigrateAccount")]
        public bool? IsMigrateAccount{ get; set; }

        /// <summary>
        /// 是否用源库Root账户覆盖目标库，值包括：false-不覆盖，true-覆盖，选择库表或者结构迁移时应该为false，注意只对旧版迁移有效
        /// </summary>
        [JsonProperty("IsOverrideRoot")]
        public bool? IsOverrideRoot{ get; set; }

        /// <summary>
        /// 是否在迁移时设置目标库只读(仅对mysql有效)，true(设置只读)、false(不设置只读，默认此值)
        /// </summary>
        [JsonProperty("IsDstReadOnly")]
        public bool? IsDstReadOnly{ get; set; }

        /// <summary>
        /// 其他附加信息，对于特定库可设置额外参数，Redis可定义如下的参数: 
        /// ["DstWriteMode":normal, 	目标库写入模式,可取值clearData(清空目标实例数据)、overwrite(以覆盖写的方式执行任务)、normal(跟正常流程一样，不做额外动作) 	"IsDstReadOnly":true, 	是否在迁移时设置目标库只读,true(设置只读)、false(不设置只读) 	"ClientOutputBufferHardLimit":512, 	从机缓冲区的硬性容量限制(MB) 	"ClientOutputBufferSoftLimit":512, 	从机缓冲区的软性容量限制(MB) 	"ClientOutputBufferPersistTime":60, 从机缓冲区的软性限制持续时间(秒) 	"ReplBacklogSize":512, 	环形缓冲区容量限制(MB) 	"ReplTimeout":120，		复制超时时间(秒) 	"IsExpireKey":"true",过期key自动淘汰]
        /// </summary>
        [JsonProperty("ExtraAttr")]
        public KeyValuePairOption[] ExtraAttr{ get; set; }

        /// <summary>
        /// pgsql迁移分类：logical(逻辑迁移)、physical(物理迁移)
        /// </summary>
        [JsonProperty("MigrateWay")]
        public string MigrateWay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DatabaseTable.", this.DatabaseTable);
            this.SetParamSimple(map, prefix + "MigrateType", this.MigrateType);
            this.SetParamObj(map, prefix + "Consistency.", this.Consistency);
            this.SetParamSimple(map, prefix + "IsMigrateAccount", this.IsMigrateAccount);
            this.SetParamSimple(map, prefix + "IsOverrideRoot", this.IsOverrideRoot);
            this.SetParamSimple(map, prefix + "IsDstReadOnly", this.IsDstReadOnly);
            this.SetParamArrayObj(map, prefix + "ExtraAttr.", this.ExtraAttr);
            this.SetParamSimple(map, prefix + "MigrateWay", this.MigrateWay);
        }
    }
}

