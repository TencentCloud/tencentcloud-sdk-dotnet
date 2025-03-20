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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceSettings : AbstractModel
    {
        
        /// <summary>
        /// 开启监控不健康替换服务。若开启则对于云监控标记为不健康的实例，弹性伸缩服务会进行替换。若不指定该参数，则默认为 False。
        /// </summary>
        [JsonProperty("ReplaceMonitorUnhealthy")]
        public bool? ReplaceMonitorUnhealthy{ get; set; }

        /// <summary>
        /// 取值范围： 
        /// CLASSIC_SCALING：经典方式，使用创建、销毁实例来实现扩缩容； 
        /// WAKE_UP_STOPPED_SCALING：扩容优先开机。扩容时优先对已关机的实例执行开机操作，若开机后实例数仍低于期望实例数，则创建实例，缩容仍采用销毁实例的方式。用户可以使用StopAutoScalingInstances接口来关闭伸缩组内的实例。监控告警触发的扩容仍将创建实例
        /// 默认取值：CLASSIC_SCALING
        /// </summary>
        [JsonProperty("ScalingMode")]
        public string ScalingMode{ get; set; }

        /// <summary>
        /// 开启负载均衡不健康替换服务。若开启则对于负载均衡健康检查判断不健康的实例，弹性伸缩服务会进行替换。若不指定该参数，则默认为 False。
        /// </summary>
        [JsonProperty("ReplaceLoadBalancerUnhealthy")]
        public bool? ReplaceLoadBalancerUnhealthy{ get; set; }

        /// <summary>
        /// 不健康替换服务的替换模式。取值范围：
        /// RECREATE：重建实例替代原有不健康实例；
        /// RESET：对原有不健康实例进行重装系统操作，可保持数据盘、内网IP、实例id等信息不发生变化，实例登录设置、主机名、增强服务和 UserData 与当前启动配置保持一致。
        /// 默认取值：RECREATE
        /// </summary>
        [JsonProperty("ReplaceMode")]
        public string ReplaceMode{ get; set; }

        /// <summary>
        /// 自动更新实例标签。默认取值为 False，配置后如伸缩组标签发生更新，会同步更新（同步更新仅支持新增、修改标签，暂不支持删除标签）伸缩组内运行中状态实例的标签，同步更新非立即生效，存在一定延迟。
        /// </summary>
        [JsonProperty("AutoUpdateInstanceTags")]
        public bool? AutoUpdateInstanceTags{ get; set; }

        /// <summary>
        /// 期望实例数同步最大最小值。默认值为 False。该参数仅对修改伸缩组接口未传入期望数的场景生效。
        /// <li>True: 修改最大值或最小值时，如与当前期望数存在冲突，则同步调整期望数。例如修改时传入最小值 2，当前期望数为 1，则同步调整期望数为 2。</li>
        /// <li>False: 修改最大值或最小值时，如与当前期望数存在冲突，报错提示不允许修改。</li>
        /// </summary>
        [JsonProperty("DesiredCapacitySyncWithMaxMinSize")]
        public bool? DesiredCapacitySyncWithMaxMinSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReplaceMonitorUnhealthy", this.ReplaceMonitorUnhealthy);
            this.SetParamSimple(map, prefix + "ScalingMode", this.ScalingMode);
            this.SetParamSimple(map, prefix + "ReplaceLoadBalancerUnhealthy", this.ReplaceLoadBalancerUnhealthy);
            this.SetParamSimple(map, prefix + "ReplaceMode", this.ReplaceMode);
            this.SetParamSimple(map, prefix + "AutoUpdateInstanceTags", this.AutoUpdateInstanceTags);
            this.SetParamSimple(map, prefix + "DesiredCapacitySyncWithMaxMinSize", this.DesiredCapacitySyncWithMaxMinSize);
        }
    }
}

