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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeDBInstanceEngineVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，格式如：cdb-c1nl9rpv 或者 cdbro-c1nl9rpv。与云数据库控制台页面中显示的实例 ID 相同，可使用 [查询实例列表](https://cloud.tencent.com/document/api/236/15872) 接口获取，其值为输出参数中字段 InstanceId 的值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 主实例数据库引擎版本，支持值包括：5.6、5.7、8.0。
        /// 说明：不支持越级升级，升级后不支持降级。
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// 切换访问新实例的方式，默认为 0。支持值包括：0 - 立刻切换，1 - 时间窗切换；当该值为 1 时，升级过程中，切换访问新实例的流程将会在时间窗内进行，或者用户主动调用接口 [切换访问新实例](https://cloud.tencent.com/document/product/236/15864) 触发该流程。
        /// </summary>
        [JsonProperty("WaitSwitch")]
        public long? WaitSwitch{ get; set; }

        /// <summary>
        /// 是否是内核子版本升级，支持的值：1 - 升级内核子版本；0 - 升级数据库引擎版本。无默认值，请指定要升级的版本类型。
        /// </summary>
        [JsonProperty("UpgradeSubversion")]
        public long? UpgradeSubversion{ get; set; }

        /// <summary>
        /// 延迟阈值。取值范围：1 - 10。无默认值，不传此参数时，延迟阈值为0，表示延迟阈值不做设置。
        /// </summary>
        [JsonProperty("MaxDelayTime")]
        public long? MaxDelayTime{ get; set; }

        /// <summary>
        /// 5.7升级8.0是否忽略关键字错误，取值范围[0,1]，1表示忽略，0表示不忽略。无默认值，不传此参数表示不做处理。
        /// </summary>
        [JsonProperty("IgnoreErrKeyword")]
        public long? IgnoreErrKeyword{ get; set; }

        /// <summary>
        /// 版本升级支持指定参数
        /// </summary>
        [JsonProperty("ParamList")]
        public UpgradeEngineVersionParams[] ParamList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "WaitSwitch", this.WaitSwitch);
            this.SetParamSimple(map, prefix + "UpgradeSubversion", this.UpgradeSubversion);
            this.SetParamSimple(map, prefix + "MaxDelayTime", this.MaxDelayTime);
            this.SetParamSimple(map, prefix + "IgnoreErrKeyword", this.IgnoreErrKeyword);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
        }
    }
}

