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

    public class MigrateOption : AbstractModel
    {
        
        /// <summary>
        /// <p>迁移对象选项，需要告知迁移服务迁移哪些库表对象</p>
        /// </summary>
        [JsonProperty("DatabaseTable")]
        public DatabaseTableObject DatabaseTable{ get; set; }

        /// <summary>
        /// <p>迁移类型，full(全量迁移)，structure(结构迁移)，fullAndIncrement(全量加增量迁移)， 默认为fullAndIncrement;注意redis,keewidb产品只支持fullAndIncrement类型。</p>
        /// </summary>
        [JsonProperty("MigrateType")]
        public string MigrateType{ get; set; }

        /// <summary>
        /// <p>数据一致性校验选项， 默认为不开启一致性校验</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Consistency")]
        public ConsistencyOption Consistency{ get; set; }

        /// <summary>
        /// <p>是否迁移账号，true(迁移账号)，false(不迁移账号)</p>
        /// </summary>
        [JsonProperty("IsMigrateAccount")]
        public bool? IsMigrateAccount{ get; set; }

        /// <summary>
        /// <p>是否用源库Root账户覆盖目标库，值包括：false-不覆盖，true-覆盖，选择库表或者结构迁移时应该为false，注意只对旧版迁移有效</p>
        /// </summary>
        [JsonProperty("IsOverrideRoot")]
        public bool? IsOverrideRoot{ get; set; }

        /// <summary>
        /// <p>是否在迁移时设置目标库只读(仅对mysql有效)，true(设置只读)、false(不设置只读，默认此值)</p>
        /// </summary>
        [JsonProperty("IsDstReadOnly")]
        public bool? IsDstReadOnly{ get; set; }

        /// <summary>
        /// <p>其他附加信息，对于特定库可设置额外参数。<br>Redis可定义如下的参数:<br>[&quot;DstWriteMode&quot;:normal,     目标库写入模式,可取值clearData(清空目标实例数据)、overwrite(以覆盖写的方式执行任务)、normal(要求目标端为空，否则校验不通过) ，不显示指定默认以覆盖写的方式执行任务    &quot;IsDstReadOnly&quot;:true,     是否在迁移时设置目标库只读,true(设置只读)、false(不设置只读)     &quot;ClientOutputBufferHardLimit&quot;:512,     从机缓冲区的硬性容量限制(MB)     &quot;ClientOutputBufferSoftLimit&quot;:512,     从机缓冲区的软性容量限制(MB)     &quot;ClientOutputBufferPersistTime&quot;:60, 从机缓冲区的软性限制持续时间(秒)     &quot;ReplBacklogSize&quot;:512,     环形缓冲区容量限制(MB)     &quot;ReplTimeout&quot;:120，        复制超时时间(秒)     &quot;IsExpireKey&quot;:&quot;true&quot;,过期key自动淘汰]</p><p>Tidb可定义如下的参数<br>[&quot;tidb_increment_enable&quot;:true,     增量迁移开关,可取值true(开启增量,平台从下列ticdc_kafka_<em>字段提取用户自建Kafka配置)、false或不传(仅做结构+全量迁移,忽略所有ticdc_kafka_</em>字段) ,严格匹配字符串true(不区分大小写)才算开启    &quot;ticdc_kafka_broker&quot;:&quot;1.1.1.1:9092&quot;,     TiCDC输出的Kafka broker地址(用户自建Kafka,平台不负责创建/回收topic),增量开启时必填    &quot;ticdc_kafka_topic&quot;:&quot;tidb_topic&quot;,     TiCDC输出的Kafka topic,增量开启时必填(连通性测试场景可不填)    &quot;ticdc_kafka_data_format&quot;:&quot;open-protocol&quot;,     数据格式,可取值open-protocol(默认,不传时按此处理)、canal-json,其他值校验不通过    &quot;ticdc_kafka_security_protocol&quot;:&quot;PLAINTEXT&quot;,     传输层安全协议,可取值PLAINTEXT(默认,无认证,忽略下方认证字段)、SASL_PLAINTEXT、SASL_SSL,其他值校验不通过    &quot;ticdc_kafka_sasl_mechanism&quot;:&quot;SCRAM-SHA-256&quot;,     SASL认证机制,可取值SCRAM-SHA-256、SCRAM-SHA-512,当security_protocol为SASL_PLAINTEXT/SASL_SSL时必填    &quot;ticdc_kafka_username&quot;:&quot;user&quot;,     Kafka SASL用户名,当security_protocol为SASL_PLAINTEXT/SASL_SSL时必填    &quot;ticdc_kafka_password&quot;:&quot;password&quot;,     Kafka SASL密码,当security_protocol为SASL_PLAINTEXT/SASL_SSL时必填(不做trim,允许首尾空格)    &quot;ticdc_kafka_ssl_ca_base64_content&quot;:&quot;base64字符串&quot;,     base64编码的CA证书内容,仅security_protocol=SASL_SSL时使用,可选(为空表示信任系统根证书)]</p>
        /// </summary>
        [JsonProperty("ExtraAttr")]
        public KeyValuePairOption[] ExtraAttr{ get; set; }

        /// <summary>
        /// <p>pgsql迁移分类：logical(逻辑迁移)、physical(物理迁移)</p>
        /// </summary>
        [JsonProperty("MigrateWay")]
        public string MigrateWay{ get; set; }

        /// <summary>
        /// <p>迁移配置阶段限速相关参数</p>
        /// </summary>
        [JsonProperty("RateLimit")]
        public RateLimit RateLimit{ get; set; }


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
            this.SetParamObj(map, prefix + "RateLimit.", this.RateLimit);
        }
    }
}

